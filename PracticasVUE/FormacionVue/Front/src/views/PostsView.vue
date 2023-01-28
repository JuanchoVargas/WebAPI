<template>
  <div class="posts">
    <h1>Posts</h1>
    <ul>
      <li
        v-for="post in posts"
        :key="post.id"
      >
      <router-link :to="`/postDetail/${post.id}`">{{post.titulo}}</router-link>
      </li>
    </ul>
    <textarea/>    
  </div>
  <div>
    <button 
    class="boton-contador"
    @click="contador.aumentarContador(1)"
    :class="{'yellow': contador.parOimpar === 'Impar'}">
    {{ contador.contadorVal }}
    </button>
  </div>
</template>


<script setup>
import { ref } from 'vue'
import{ useContador } from '@/stores/counter'
const posts =  ref([
  {
    id:'id1',
    titulo: 'Post1'
  },
  {
    id:'id2',
    titulo: 'Post2'
  },
  {
    id:'id3',
    titulo: 'Post3'
  }
])

const contador = useContador();


</script>


<style scoped>

ul{
  margin-bottom: 30px;
}
@media (min-width: 1024px) {
  .about {
    min-height: 100vh;
    display: flex;
    align-items: center;
  }
}

.boton-contador{
  font-size: 60px;
  width: 100%;
  background-color: green;
}

.boton-contador.yellow {
  background-color: yellowgreen;
}
</style>
