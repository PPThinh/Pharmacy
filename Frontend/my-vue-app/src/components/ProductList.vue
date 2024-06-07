<template>
    <div>
      <h1>Danh sách sản phẩm</h1>
      <ul>
        <li v-for="product in products" :key="product.id">
          {{ product.name }} - {{ product.price }}
          <router-link :to="{ name: 'UpdateProduct', params: { id: product.id } }">Cập nhật</router-link>
        </li>
      </ul>
    </div>
  </template>
  
  <script>
  import axios from 'axios';
  
  export default {
    data() {
      return {
        products: []
      };
    },
    async created() {
      try {
        const response = await axios.get('http://localhost:5033/api/product');
        this.products = response.data;
      } catch (error) {
        console.error('Lỗi khi lấy dữ liệu sản phẩm:', error);
      }
    }
  };
  </script>
  