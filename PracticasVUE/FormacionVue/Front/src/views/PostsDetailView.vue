<template>
  <div class="post-detail">
    <h1>Aca nos llevara y despliegara una pagina en especifico</h1>
    <p>Se mostrara la informacion relacionada al ID # {{ $route.params.id }} aqui!</p>
    <div>
      <button @click="mostrarID">Mostrar ID ingresado</button>
    </div>
    <div>
      <button @click="home3sec">Ir a Home en 3 segundos</button>
    </div>
    <div>
      <button @click="pasthpost1">Ir al Post #1</button>
    </div>
    <p><router-link to="/posts">&lt; Atras</router-link></p>
  </div>
</template>


<script setup>
import{ useRoute, useRouter} from 'vue-router'

const route = useRoute()
const router = useRouter();
const mostrarID =() =>{
  alert(`El id de esta pagina es: ${route.params.id}`)
}

const home3sec =() =>{
  setTimeout(() => {
    router.push({name: 'home'})
  }, 3000)
}

const pasthpost1 =() =>{
  router.push({
    name: 'postDetail',
    params: {
      id: 'id1'
    }
  })
}

</script>



<style>
@media (min-width: 1024px) {
  .about {
    min-height: 100vh;
    display: flex;
    align-items: center;
  }
}
</style>
