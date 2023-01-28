import { createRouter, createWebHistory } from 'vue-router'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/repasando',
      name: 'repasando',
      component:() => import('../views/RepasandoView.vue')
    },
    {
      path: '/libros',
      name: 'libros',
      component: () => import('../views/LibrosView.vue')
    }
  ]
})

export default router
