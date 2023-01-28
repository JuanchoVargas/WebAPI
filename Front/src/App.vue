<script setup>
import { RouterLink, RouterView } from "vue-router";
</script>

<template>
  <nav class="navbar navbar-expand navbar-light bg-light">
    <div class="nav navbar-nav">
      <RouterLink to="/Listar" class="nav-link"
        >Registro Base de Datos</RouterLink
      >
      <RouterLink to="/Crear" class="nav-link">Ingresar Autores</RouterLink>
      <RouterLink to="/Editar" class="nav-link">Actualizar</RouterLink>
    </div>
  </nav>
  <br />
  <RouterView />
</template>

<style scoped></style>
