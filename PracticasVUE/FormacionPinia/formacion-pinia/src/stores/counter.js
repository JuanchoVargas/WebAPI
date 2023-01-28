import { defineStore } from 'pinia'

export const useCounterStore = defineStore('counter', {
  state:() =>({
    count:  10,
  }),
  getters:() =>({
    numDigitos: (store) => store.count.toString().length,
  })
});
