import Vue from 'vue';
import Router from 'vue-router';

import HomePage from '../components/HomePage'
import LoginPage from '../components/LoginPage'
import RegisterPage from '../components/RegisterPage'

Vue.use(Router);

export const router = new Router({
  mode: 'history',
  routes: [
    { path: '/', component: HomePage },
    { path: '/login', component: LoginPage },
    { path: '/register', component: RegisterPage },

    // nếu không sẽ chuyển đến trang home
    { path: '*', redirect: '/' }
  ]
});

router.beforeEach((to, from, next) => {
  // chuyển đến trang login nếu chưa được login
  const publicPages = ['/login', '/register'];
  const authRequired = !publicPages.includes(to.path);
  const loggedIn = localStorage.getItem('user');

  if (authRequired && !loggedIn) {
    return next('/login');
  }

  next();
})
