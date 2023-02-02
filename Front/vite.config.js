<<<<<<< HEAD
import { fileURLToPath, URL } from 'node:url'

import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue'
=======
import { defineConfig } from "vite";
import vue from "@vitejs/plugin-vue";
>>>>>>> 14267ff5fbf2bf9636676ef1fc0ca79d36ab69f2

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [vue()],
<<<<<<< HEAD
  resolve: {
    alias: {
      '@': fileURLToPath(new URL('./src', import.meta.url))
    }
  }
})
=======
  server: { port: 3000 },
});
>>>>>>> 14267ff5fbf2bf9636676ef1fc0ca79d36ab69f2
