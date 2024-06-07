import React, { useState } from 'react';
import axios from 'axios';

const ApiComponent = () => {
    const [data, setData] = useState([]);

    const fetchData = async () => {
        try {
            const response = await axios.get('http://localhost:5033/api/product'); // Thay đổi URL này thành endpoint API của bạn
            setData(response.data);
        } catch (error) {
            console.error('Error fetching data:', error);
        }
    };

    return (
        <div className="container">
            <h1>Data from API</h1>
            <button onClick={fetchData}>Fetch Data</button>
            <div id="dataDisplay">
                {data.map(item => (
                    <div key={item.id} className="data-item">
                        <p className="product-name">Name: {item.name}</p>
                        <p className="company-name">Company Name: {item.companyName}</p>
                        <p className="product-price">Price: ${item.price}</p>
                    </div>
                ))}
            </div>
        </div>
    );
};

export default ApiComponent;
