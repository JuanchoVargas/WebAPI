import { reactive, computed, watch,nextTick } from 'vue'

export function useContador(){


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
  const increaseCounter = async(aumento) => {
    contador.contar += aumento;
    await nextTick()
  };
  
  
  const decreaseCounter = (decremento) => {
    contador.contar -= decremento;
  };
  
  const parOimpar= computed(()=>{
    if (contador.contar % 2 === 0) {
      return 'par';
    }else {
      return 'impar';
    }
  })

  return{
    contador,
    increaseCounter,
    decreaseCounter,
    parOimpar
  }
}