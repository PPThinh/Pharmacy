<template>
    <div>
      <h1>Tạo mới sản phẩm</h1>
      <form @submit.prevent="createProduct">
        <div class="form-group">
          <label for="name">Tên sản phẩm:</label>
          <input type="text" v-model="name" id="name" required />
        </div>
        <div class="form-group">
          <label for="companyName">Tên công ty:</label>
          <select v-model="companyName" id="companyName" required>
            <option v-for="(value, key) in CompanyEnum" :key="key" :value="value">{{ key }}</option>
          </select>
        </div>
        <div class="form-group">
          <label for="price">Giá:</label>
          <input type="number" v-model="price" id="price" required />
        </div>
        <button type="submit">Tạo</button>
      </form>
    </div>
  </template>
  
  <script>
  import axios from 'axios';
  
  const CompanyEnum = {
    CompanyA: 'CompanyA',
    CompanyB: 'CompanyB'
  };
  
  export default {
    data() {
      return {
        name: '',
        companyName: CompanyEnum.CompanyA, // Giá trị mặc định
        price: 0,
        CompanyEnum
      };
    },
    methods: {
      async createProduct() {
        try {
          await axios.post('<template>
  <div>
    <h1>Tạo mới sản phẩm</h1>
    <form @submit.prevent="createProduct">
      <div class="form-group">
        <label for="name">Tên sản phẩm:</label>
        <input type="text" v-model="name" id="name" required />
      </div>
      <div class="form-group">
        <label for="companyName">Tên công ty:</label>
        <select v-model="companyName" id="companyName" required>
          <option v-for="(value, key) in CompanyEnum" :key="key" :value="value">{{ key }}</option>
        </select>
      </div>
      <div class="form-group">
        <label for="price">Giá:</label>
        <input type="number" v-model="price" id="price" required />
      </div>
      <button type="submit">Tạo</button>
    </form>
  </div>
</template>

<script>
import axios from 'axios';

const CompanyEnum = {
  CompanyA: 'CompanyA',
  CompanyB: 'CompanyB'
};

export default {
  data() {
    return {
      name: '',
      companyName: CompanyEnum.CompanyA, // Giá trị mặc định
      price: 0,
      CompanyEnum
    };
  },
  methods: {
    async createProduct() {
      try {
        await axios.post('http://localhost:5033/api/product', {
          name: this.name,
          companyName: this.companyName,
          price: this.price
        });
        alert('Tạo sản phẩm thành công');
      } catch (error) {
        console.error('Lỗi khi tạo sản phẩm:', error);
      }
    }
  }
};
</script>
', {
            name: this.name,
            companyName: this.companyName,
            price: this.price
          });
          alert('Tạo sản phẩm thành công');
        } catch (error) {
          console.error('Lỗi khi tạo sản phẩm:', error);
        }
      }
    }
  };
  </script>
  