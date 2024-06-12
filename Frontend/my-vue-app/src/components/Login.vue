<template>
    <div>
      <h2>Login</h2>
      <form @submit.prevent="login">
        <div>
          <label for="username">Username:</label>
          <input type="text" v-model="username" required>
        </div>
        <div>
          <label for="password">Password:</label>
          <input type="password" v-model="password" required>
        </div>
        <button type="submit">Login</button>
      </form>
      <p v-if="error">{{ error }}</p>
    </div>
  </template>
  
  <script>
  import axios from 'axios';
  
  export default {
    data() {
      return {
        username: '',
        password: '',
        error: ''
      };
    },
    methods: {
      async login() {
        try {
          const response = await axios.post('http://localhost:5033/api/account/login', {
            username: this.username,
            password: this.password
          });
          localStorage.setItem('token', response.data.token);
          this.$router.push({ name: 'Home' }); // Chuyển hướng đến trang Home
        } catch (error) {
          this.error = 'Invalid username or password';
        }
      }
    }
  };
  </script>
  