<template>
  <div class="container">
    <div class="card">
      <div class="card-header">Autores</div>
      <div class="card-body">
        <table class="table">
          <thead>
            <tr>
              <th>ID</th>
              <th>Nombre</th>
              <th>Editar</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="autor in autores" key="autores.id">
              <td scope="row">{{ autor.id }}</td>
              <td>{{ autor.nombre }}</td>
              <td>
                <div class="btn-group" role="group" aria-label="">
                  <router-link :to="{name:'Editar' ,param:{id:autor.id}}" class="btn btn-info">Editar</router-link>
                  <button type="button" v-on:click="borrarAutor(autor.id)" class="btn btn-danger">Borrar</button>
                </div>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      autores: [],
    };
  },

  created: function () {
    this.consultarAutores();
  },

  methods: {
    consultarAutores() {
      fetch("https://localhost:7025/api/autores")
        .then((respuesta) => respuesta.json())
        .then((datosRespuesta) => {
          console.log(datosRespuesta);
          this.autores = [];
          if (typeof datosRespuesta[0].success === "undefined") {
            this.autores = datosRespuesta;
          }
        })
        .catch(console.log);
    },
    borrarAutor(id){
      fetch("https://localhost:7025/api/autores/?borrar="+id)
        .then((respuesta) => respuesta.json())
        .then((datosRespuesta) => {
          console.log(datosRespuesta);
          window.location.href='Listar';
        })
        .catch(console.log)
        ;
    }
  },
};
</script>
