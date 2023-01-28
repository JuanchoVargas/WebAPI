<script setup>
/**
 * Imports
 */


import { useAuthStore } from "@/stores/auth"
const authStore = useAuthStore();


</script>


<template>
  <div>
  <nav>
    <router-link to="/">Home</router-link> | 
    <router-link to="/about">About</router-link>
  </nav>
  <RouterView/>
  </div>
</template>

<style scoped></style>
