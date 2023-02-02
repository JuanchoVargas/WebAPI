<script setup>
import { ref } from 'vue'
import{ useContador } from '@/stores/counter'


// ? de esta manera puedo crear una propiedad No responsive estatica 
const tituloApp = ref('Aprendiendo en VUE');
const tituloAppRef = ref(null);
const contador = useContador(); 

const setName =(e)=>{
  let nombreEquipo= e.target.value; 
  contador.titulo = nombreEquipo;
  tituloApp.value = nombreEquipo;
  console.log(nombreEquipo);
}


</script>


<template>
  <div class="home">
  <h2 ref="tituloAppRef">{{ tituloApp }}</h2>
  <h3> Titulos {{contador.titulo}}</h3>
    <div>
      <button @click="contador.disminuirContador (2)" class="btn">--</button>
      <button @click="contador.disminuirContador (1)" class="btn" >-</button> 
      <span class="counter">{{ contador.contadorVal }}</span>
      <button @click="contador.aumentarContador (1)" class="btn" >+</button>
      <button @click="contador.aumentarContador (2)" class="btn">++</button>
    </div>
    <p >Este Contador es {{ contador.parOimpar }}</p>
    <div class="edit">
      <h4>Edicion Nombre del Equipo</h4>
      <input type="text" v-on:keyup="setName">
    </div>
</div>   
</template>



<style>
.home{
  text-align: center;
  padding: 20px;
}

.btn,.counter{
  font-size: 40px;
  margin: 10px;
}

.edit{
  margin-top: 6px;
}
</style>