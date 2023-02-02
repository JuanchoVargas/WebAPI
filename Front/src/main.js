import { createApp } from 'vue'
<<<<<<< HEAD
import { createPinia } from 'pinia'
import axios from 'axios'
import VueAxios from 'vue-axios'
import App from './App.vue'
import router from './router'


const app = createApp(App)
app.use(createPinia())
app.use(router)
app.use(VueAxios, axios)
app.mount('#app')
=======
import './style.css'
import App from './App.vue'

createApp(App).mount('#app')
>>>>>>> 14267ff5fbf2bf9636676ef1fc0ca79d36ab69f2
