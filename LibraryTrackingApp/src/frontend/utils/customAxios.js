import { site } from '@/constants/site';
import axios from 'axios';

const API_BASE_URL = site.API_BASE_URL;

const customAxios = axios.create({
  baseURL: API_BASE_URL,
  timeout: 5000, 
  headers: {
    'Content-Type': 'application/json',
  },
});

export default customAxios;
