<template>
    <div class="container">
      <h1>Tạo dữ liệu mới</h1>
      <form @submit.prevent="createPost">
        <div class="form-group">
          <label for="name">Tên sản phẩm:</label>
          <input type="text" v-model="name" id="name" required />
        </div>
        <div class="form-group">
          <label for="companyName">Tên công ty:</label>
          <input type="text" v-model="companyName" id="companyName" required />
        </div>
        <div class="form-group">
          <label for="price">Giá:</label>
          <input type="number" v-model="price" id="price" required />
        </div>
        <div class="form-group">
          <label for="description">Thông tin:</label>
          <input type="text" v-model="description" id="description" required />
        </div>
        <button type="submit">Tạo</button>
      </form>
      <div v-if="postData" class="post-result">
        <h2>Dữ liệu đã tạo</h2>
        <p><strong>Tên sản phẩm:</strong> {{ postData.name }}</p>
        <p><strong>Tên công ty:</strong> {{ postData.companyName }}</p>
        <p><strong>Giá:</strong> ${{ postData.price }}</p>
        <p><strong>Thông tin:</strong> {{ postData.description }}</p>
      </div>
    </div>
  </template>
  
  <script>
  import axios from 'axios';
  
  export default {
    data() {
      return {
        name: '',
        companyName: '',
        price: 0,
        description: '',
        postData: null,
      };
    },
    methods: {
      async createPost() {
        try {
          const response = await axios.post('http://localhost:5033/api/product', {
            name: this.name,
            companyName: this.companyName,
            price: this.price,
            description: this.description
          });
          this.postData = response.data;
        } catch (error) {
          console.error('Lỗi khi tạo dữ liệu:', error);
        }
      },
    },
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
  
  .form-group {
    margin-bottom: 15px;
    text-align: left;
  }
  
  label {
    display: block;
    font-weight: bold;
    margin-bottom: 5px;
  }
  
  input {
    width: 100%;
    padding: 8px;
    margin-bottom: 10px;
    border-radius: 5px;
    border: 1px solid #ccc;
  }
  
  button {
    padding: 10px 20px;
    font-size: 16px;
    cursor: pointer;
    border: none;
    border-radius: 5px;
    background-color: #007BFF;
    color: white;
    transition: background-color 0.3s;
  }
  
  button:hover {
    background-color: #0056b3;
  }
  
  .post-result {
    margin-top: 20px;
    text-align: left;
  }
  
  .post-result h2 {
    margin-bottom: 10px;
  }
  
  .post-result p {
    margin: 5px 0;
  }
  </style>
  