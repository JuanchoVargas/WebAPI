
<template>
  <div class="home">
  <h2>{{ tituloApp }}</h2>
  <h3> Titulos {{contador.Titulo}}</h3>
    <div>
      <button @click="decreaseCounter(2)" class="btn">--</button>
      <button @click="decreaseCounter(1)" class="btn">-</button> 
      <span class="counter">{{ contador.contar }}</span>
      <button @click="increaseCounter(1)" class="btn">+</button>
      <button @click="increaseCounter(2)" class="btn">++</button>
    </div>
    <p >Este Contador es {{ parOimpar }}</p>
    <div class="edit">
    
      <h4>Edicion Nombre del Equipo</h4>
      <input v-model="contador.Titulo" type="text" v-autofocus>
    </div>
</div>  
<!-- 
  <router-view v-slot="{Component }">
  <keep-alive>
    <component :is="Component"/>
  </keep-alive>
  </router-view> --> 
</template>

// ? Forma actualizada organizar mis metodos 
<script setup >
import { reactive, computed, watch,onMounted } from 'vue';

import { vAutofocus} from '/directives/vAutofocus'


// ? de esta manera puedo crear una propiedad No responsive estatica 
const tituloApp = 'Aprendiendo en VUE';

onMounted(() => {
  console.log('Algo del titulo');
})
// *Se incluye toda la informacion necesaria del Objeto, creacion del Objeto contador,  varios tipos de Datos en un objeto 
// ?La propiedad reactive nos permite manipular los obejtos que hayamos creado, si esto no es nevcesario no debemos relizar este proceso
const contador = reactive({
  contar: 0,
  Titulo: "Contador"
})

watch (() => contador.contar, (maximoContador)=>{
  if (maximoContador >= 18){
    alert ('Ningun equipo en Colombia tiene tantos Titulos');
  }
}) 

// ?Puedo de la misma manera agregar parametros de ingreso para gestinoar valores 
const increaseCounter = (aumento) => {
  contador.contar += aumento;
};
const decreaseCounter = (decremento) => {
  contador.contar -= decremento;
};

onMounted(() => {
  console.log('Algo de el contador');
})

const parOimpar= computed(()=>{
  if (contador.contar % 2 === 0) {
    return 'par';
  }else {
    return 'impar';
  }
})


</script>

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