<template>
  <div class="repasando">
    <h1 :style="repaso">{{ nombre }}</h1>
    <div>
      <h2>Recorriendo un Array</h2>
      <ul>
        <li v-for="fruta in arrayFrutas1" key="fruta.id">
          {{ fruta.name }}-{{ fruta.price }}-{{ fruta.description }}
        </li>
      </ul>
    </div>

    <div>
      <h2>Recorriendo un Objeto</h2>
      <ul>
        <li v-for="(valorProp, nombreProp) in frutaInfo" :key="frutaInfo.id">
          {{ nombreProp }}: {{ valorProp }}
        </li>
      </ul>
    </div>

    <div>
      <h2>Recorriendo un Array con condiciones en las propiedades</h2>
      <ul>
        <template v-for="fruta in arrayFrutas2" :key="fruta.name">
          <li v-if="fruta.stock > 0">{{ fruta.name }} - {{ fruta.price }}</li>
        </template>
      </ul>
    </div>

    <div>
      <button @click="manejoClick">{{ boton }}</button>
    </div>
    <br :class="organizar" />
    <h2 :class="coloresPN">
      <button @click="decrementoClick">-</button>
      {{ contador }}
      <button @click="aumentoClick">+</button>
    </h2>
    <div>
      <button @click="agregarLista">Agregar Numero a la lista</button>
    </div>
    <br />
    <ul>
      <li v-for="numerosGuardados in arrayEditable" key="index">
        {{ numerosGuardados }}
      </li>
    </ul>
  </div>
</template>

<script setup>
/**
 * Imports
 */

import { ref, computed } from "vue";
import { RouterLink, RouterView } from "vue-router";

/**
 * variables
 */

const nombre = "Repaso con VUE";
const repaso = "color : blue";
const contador = ref(0);
const boton = ref("Activame");
const arrayEditable = ref([]);

/**
 * Recorrer un array
 */
const arrayFrutas1 = [
  {
    id: 1,
    name: "Manzana",
    price: "$1.00",
    description: "Una manzana",
  },
  {
    id: 2,
    name: "Pera",
    price: "$2.00",
    description: "Una pera",
  },
  {
    id: 3,
    name: "Naranja",
    price: "$3.00",
    description: "Una naranja",
  },
];

/**
 * Recorrer un Objeto
 */

const frutaInfo = {
  id: 1,
  name: "Manzana",
  price: "$1.00",
  description: "Una manzana",
};

/**
 * Recorrer Un array con condiciones en las propiedades
 */

const arrayFrutas2 = [
  {
    name: "Manzana",
    price: "$1.00",
    description: "Una manzana",
    stock: 0,
  },
  {
    name: "Pera",
    price: "$2.00",
    description: "Una pera",
    stock: 10,
  },
  {
    name: "Naranja",
    price: "$3.00",
    description: "Una naranja",
    stock: 20,
  },
];

/**
 * Metodos
 */

const manejoClick = () => {
  boton.value = "Me diste click";
};

const decrementoClick = () => {
  contador.value -= 1;
};
const aumentoClick = () => {
  contador.value += 1;
};

const coloresPN = computed(() => {
  if (contador.value == 0) {
    return "cero";
  } else if (contador.value > 0) {
    return "positivo";
  } else {
    return "negativo";
  }
});

const agregarLista = () => {
  arrayEditable.value.push(contador.value);
};
</script>

<style>
.organizar {
  margin-top: 10px;
}

.positivo {
  color: green;
}

.negativo {
  color: red;
}

.cero {
  color: white;
}


</style>
