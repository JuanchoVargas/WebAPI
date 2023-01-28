<script setup>
/**
 * Imports
 */
//* Para acceder a una propiedad, llamo mi metodo creado en Pinia donde esta la propiedad que deseo utilizar
import { useCounterStore } from "@/stores/counter"; //? al ser un import de Pinia una funcion NO debemos agregar el .(tipo de archivo)

/**
 * Variables
 */
//* Asigno una variable de acceso para usar en este componente
const store = useCounterStore();

//* Por ultimo en html , utlizo la busqueda con . para el valor de la propiedad

function disminuir(store){
  store.count--;
}
const aumentar=(store)=> {
  store.count++;
}
</script>

<template>
  <div>
    <button @click="disminuir">Disminiur</button> -- Count Value: {{ store.count }} --
    <button @click="aumentar">Aumentar</button> <br />
    Cantidad de digitos es: {{ store.numDigitos }}
  </div>
</template>
