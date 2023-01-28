import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import Editar from '../components/Editar.vue'
import Crear from '../components/Crear.vue'
import Listar from '../components/Listar.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'HomeView',
      component: HomeView
    },
    {
      path: '/crear',
      name: 'Crear',
      component: Crear
    },
    {
      path: '/editar',
      name: 'Editar',
      component: Editar
    },
    {
      path: '/listar',
      name: 'Listar',
      component: Listar
    },
  ]
})

export default router
