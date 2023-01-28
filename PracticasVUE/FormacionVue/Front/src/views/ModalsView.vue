<template>
  <div class="modals">
    <h1>Modals</h1>
    <button @click="mostrarModal=true">Show modals</button>
    
    <div
    v-if = 'mostrarModal'
    class="modal"
    >
      <h1>This is a modal</h1>
      <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Enim iure similique, eos esse quae commodi libero, ab mollitia architecto asperiores obcaecati magnam necessitatibus dolorum vero eligendi. Molestias dolorem voluptate eos.</p>
      <button @click="mostrarModal=false">Hide modal</button>
    </div>
  </div>
</template>

<script setup>
//* Imports
import { ref } from "vue";
const mostrarModal = ref(false);
</script>

<style>
.modal {
  background: white;
  padding: 10px;
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  z-index: 1;
  
}
</style>