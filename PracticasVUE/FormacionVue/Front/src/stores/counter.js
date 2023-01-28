import { ref, computed } from 'vue'
import { defineStore } from 'pinia'

export const useContador = defineStore({
    id: 'counter',
    state:() => ({
      contadorVal: 0, 
      titulo: 'Equipo'    
    }),

    actions:{
      aumentarContador(aumento){
        this.contadorVal+=aumento;
      },
      disminuirContador(decremento){
        this.contadorVal-=decremento;;
      }
    },
    getters:{
      parOimpar:(estado)=> {
        if(estado.contadorVal%2 === 0) return 'Par'
        return 'Impar'
      }
    }

})
