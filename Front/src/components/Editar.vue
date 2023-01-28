<template>
  <div class="container">
    <div class="card">
      <div class="card-header">Editar Autor</div>
      <div class="card-body">
        <form v-on:submit.prevent="actualizarRegistro">
          <div class="form-group">
            <label for="nombre">Nombre:</label>
            <input
              type="text"
              class="form-control"
              required
              name="nombre"
              v-model="autor.nombre"
              id="nombre"
              aria-describedby="helpId"
              placeholder="Nombre"
            />
            <small id="helpId" class="form-text text-muted"
              >Escribe el nuevo Nombre del Autor</small
            >
          </div>
          <div class="btn-group" role="group" aria-label="">
            <button type="submit" class="btn btn-danger">Modificar</button>
            <router-link to="/Listar" class="btn btn-warning"> Cancelar</router-link>
          </div>
        </form>
      </div>
    </div>
  </div>
</template>

<script>

export default {
  data() {
    return {
      autor:{},
    }  
  },
  methods:{

    obtenerInformacionID(){
      
    }

  }
}


</script>