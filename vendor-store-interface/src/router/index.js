import { createRouter, createWebHistory } from "vue-router";
import HomeView from "../views/HomeView.vue";
import LoginViewVue from "../views/LoginView.vue";
import RegisterVue from "../views/RegisterView.vue";

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: "/th",
      name: "home",
      component: HomeView,
    },
    {
      path: "/",
      name: "login",
      component: LoginViewVue
    },
    {
      path: "/member/register",
      name: "register",
      component: RegisterVue
    }
  
  ],
});

export default router;
