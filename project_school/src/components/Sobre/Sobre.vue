<template>
  <div>
    <titulo texto="Sobre" :btnVoltar="true" />
    <p>
      Lorem ipsum dolor, sit amet consectetur adipisicing elit. Quas suscipit
      facilis ex minus nulla fugiat nisi delectus, minima recusandae, officia
      laborum porro voluptates reiciendis nesciunt, provident nostrum? Velit,
      ipsum soluta.
    </p>
    <p>
      Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ipsum nam atque
      vel magni iure nisi cum sit! Rerum error iste voluptatibus. Officia, ut
      placeat! Corporis enim ratione quaerat assumenda veniam.
    </p>
  </div>
</template>

<script>
import Titulo from "../_share/Titulo";
export default {
  components: {
    Titulo,
  },
};
</script>

<style scoped>
</style>