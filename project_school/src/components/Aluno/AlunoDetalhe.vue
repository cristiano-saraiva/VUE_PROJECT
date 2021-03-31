<template>
  <div>
    <titulo :texto="`Aluno: ${aluno.nome}`" :btnVoltar="!viwer">
      <button v-show="viwer" class="btn btn_editar" @click="editar()">
        Editar
      </button>
    </titulo>
    <table>
      <tbody>
        <tr>
          <td class="colPequeno">Matricula:</td>
          <td>
            <label for="">{{ aluno.id }} </label>
          </td>
        </tr>
        <tr>
          <td class="colPequeno">Nome:</td>
          <td>
            <label v-if="viwer" for="">{{ aluno.nome }} </label>
            <input v-else v-model="aluno.nome" type="" />
          </td>
        </tr>
        <tr>
          <td class="colPequeno">Sobrenome</td>
          <td>
            <label v-if="viwer" for="">{{ aluno.sobrenome }} </label>
            <input v-else v-model="aluno.sobrenome" type="" />
          </td>
        </tr>
        <tr>
          <td class="colPequeno">Data Nascimento</td>
          <td>
            <label v-if="viwer" for="">{{ aluno.dtNasc }} </label>
            <input v-else v-model="aluno.dtNasc" type="" />
          </td>
        </tr>
        <tr>
          <td class="colPequeno">Professor:</td>
          <td>
            <label v-if="viwer" for="">{{ aluno.professor.nome }} </label>
            <select v-else v-model="aluno.professor">
              <option
                v-for="(professor, index) in professores"
                :key="index"
                :value="professor"
              >
                {{ professor.nome }}
              </option>
            </select>
          </td>
        </tr>
      </tbody>
    </table>
    <div style="margin-top: 10px">
      <div v-if="!viwer">
        <button class="btn btnSalvar" @click="salvar(aluno)">Salvar</button>
        <button class="btn btnCancelar" @click="cancelar()">Cancelar</button>
      </div>
    </div>
  </div>
</template>

<script>
import Titulo from "../_share/Titulo";
export default {
  components: {
    Titulo,
  },
  data() {
    return {
      professores: [],
      aluno: {},
      id: this.$route.params.id,
      viwer: true,
    };
  },
  created() {
    this.$http
      .get(
        "http://localhost:3000/alunos/" + this.id
      ) /* faz um get no servidor */
      .then((res) => res.json()) /* tranformar em json */
      .then(
        (aluno) => (this.aluno = aluno)
      ); /* atribuir pata parametro aluno */

    this.$http
      .get("http://localhost:3000/professores")
      .then((res) => res.json())
      .then((professor) => {
        this.professores = professor;
      });
  },
  methods: {
    editar() {
      this.viwer = !this.viwer;
    },
    salvar(_aluno) {
      let _alunoEdit = {
        id: _aluno.id,
        nome: _aluno.nome,
        sobrenome: _aluno.sobrenome,
        dtNasc: _aluno.dtNasc,
        professor: _aluno.professor,
      };
      this.$http.put(
        `http://localhost:3000/alunos/${_alunoEdit.id}`,
        _alunoEdit
      );
      this.viwer = !this.viwer;
    },
    
    cancelar() {
      this.viwer = !this.viwer;
    },
  },
};
</script>

<style scoped>
.colPequeno {
  width: 20px;
}
input,
select {
  margin: 0px;
  padding: 5px 10px;
  font-size: 0.9em;
  font-family: Montserrat;
  border-radius: 5px;
  border: 1px solid silver;
  background-color: rgb(245, 245, 245);
  width: 95%;
}
select {
  height: 38px;
  width: 100%;
}

.btn_editar {
  float: right;
  background-color: rgb(76, 186, 249);
}
.btnSalvar {
  float: right;
  background-color: rgb(79, 196, 68);
}
.btnCancelar {
  float: left;
  background-color: rgb(249, 186, 82);
}
</style>