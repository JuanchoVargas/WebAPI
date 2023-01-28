<template>
  <div :class="nav">
    <router-link to="/repasando">Autores</router-link> - 
    <router-link to="/libros">Libros</router-link>
    <div>
      <router-view />
    </div>
  </div>

  <div>
  Holi
  </div>
</template>

<script>

</script>


<style scoped>
.nav {
  text-align: left;
  margin-left: -1rem;
  font-size: 1rem;

  padding: 1rem 0;
  margin-top: 1rem;
}
</style>