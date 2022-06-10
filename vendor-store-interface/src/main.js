import { createApp } from "vue";
import { createPinia } from "pinia";
import "bootstrap/dist/css/bootstrap.min.css"
import "bootstrap"
import App from "./App.vue";
import router from "./router";
import { DatePicker,Radio } from 'ant-design-vue';
import 'ant-design-vue/dist/antd.css'; // or 'ant-design-vue/dist/antd.less'
const app = createApp(App);

app.use(createPinia());
app.use(router);
app.use(Radio);
app.use(DatePicker);
app.mount("#app");
