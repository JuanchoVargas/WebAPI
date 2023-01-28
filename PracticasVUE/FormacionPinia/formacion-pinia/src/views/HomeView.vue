<script setup>
/**
 * Imports
 */

import Contador from '@/components/Contador.vue';//! Por el contrario al ser este un componente debemos especificar el .(tipo de archivo), ademas al no tratarse de una funcion no debo usar las llaves para llamar al componente
</script>

<template>
  <main>
    Hola Mundo
  <Contador/>
  </main>
</template>
