<template>
  <div class="container">
    <div class="card">
      <div class="card-header">Agregar Nuevo Autor</div>
      <div class="card-body">
        <form v-on:submit.prevent="agregarRegistro">
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
              >Escribe el Nombre del Autor</small
            >
          </div>
          <div class="btn-group" role="group" aria-label="">
            <button type="submit" class="btn btn-success">Agregar</button>
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
      autor:[],
    };  
  },
  methods: {
    agregarRegistro() {
      console.log(this.autor);
      var datosEnviar = { nombre: this.autor.nombre };
      fetch("https://localhost:7025/api/autores/?insert=1", {
        method: "POST",
        body: JSON.stringify(datosEnviar),
      })
        .then((respuesta) => respuesta.json())
        .then((datosRespuesta) => {
          console.log(datosRespuesta);
          window.location.href='Listar';
        });
    },
  },
};
</script>
