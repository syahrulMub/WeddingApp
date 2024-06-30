// api.js
import axios from "axios";

const API_URL = "https://localhost:44472/"; // Ganti dengan URL API Anda

const sendingRequest = async (url, method = "GET", data = null) => {
  try {
      console.log('seng tak kirim',data);
    const response = await axios({
      url: `${API_URL}${url}`,
      method,
      data,
    });
    return response.data;
  } catch (error) {
    console.log("iki dataku", data);
    console.error("Error making request:", error);
    throw error;
  }
};

export { sendingRequest };
