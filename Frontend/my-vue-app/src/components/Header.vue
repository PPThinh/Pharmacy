<template>
    <div class="header">
      <router-link to="/">Danh sách sản phẩm</router-link>
      <router-link to="/create-product">Tạo mới sản phẩm</router-link>
      <router-link to="/update-product/1">Cập nhật sản phẩm</router-link> <!-- Update sản phẩm với ID 1 -->
    </div>
  </template>
  
  <script>
  export default {
    name: 'Header'
  };
  </script>
  
  <style>
  .header {
    display: flex;
    justify-content: space-around;
    padding: 10px;
    background-color: #f8f8f8;
  }
  .header a {
    text-decoration: none;
    color: #333;
    padding: 10px 20px;
    border: 1px solid #ccc;
    border-radius: 4px;
  }
  .header a:hover {
    background-color: #ddd;
  }
  </style>
  