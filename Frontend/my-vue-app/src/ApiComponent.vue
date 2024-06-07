<template>
    <div class="container">
      <h1>Data from API</h1>
      <button @click="fetchData">Fetch Data</button>
      <div id="dataDisplay">
        <div v-for="item in data" :key="item.id" class="data-item">
          <p class="product-name">Tên sản phẩm: {{ item.name }}</p>
          <p class="company-name">Công ty: {{ item.companyName }}</p>
          <p class="product-price">Giá: ${{ item.price }}</p>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  import axios from 'axios';
  
  export default {
    data() {
      return {
        data: []
      };
    },
    methods: {
      async fetchData() {
        try {
          const response = await axios.get('http://localhost:5033/api/product'); // Thay đổi URL này thành endpoint API của bạn
          this.data = response.data;
        } catch (error) {
          console.error('Error fetching data:', error);
        }
      }
    }
  };
  </script>
  
  <style>
  .container {
    font-family: Arial, sans-serif;
    background-color: #f0f0f0;
    padding: 20px;
    border-radius: 8px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    text-align: center;
  }
  
  h1 {
    margin-bottom: 20px;
  }
  
  button {
    padding: 10px 20px;
    font-size: 16px;
    cursor: pointer;
    border: none;
    border-radius: 5px;
    background-color: #55ff00;
    color: white;
    transition: background-color 0.3s;
  }
  
  button:hover {
    background-color: #1d6005;
  }
  
  #dataDisplay {
    margin-top: 20px;
    text-align: left;
  }
  
  .data-item {
    background-color: #ffffff;
    border: 1px solid #dddddd;
    border-radius: 5px;
    padding: 10px;
    margin-bottom: 10px;
  }
  
  .product-name {
    font-size: 18px;
    font-weight: bold;
    color: #333333;
  }
  
  .company-name {
    font-size: 16px;
    color: #555555;
  }
  
  .product-price {
    font-size: 16px;
    color: #ffe600;
    font-weight: bold;
  }
  </style>
  