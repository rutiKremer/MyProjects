const express = require("express");
const mongoose = require("mongoose");
const cors = require('cors'); 
const app = express();
const producerRouter = require('./Controllers/producerController');
const eventRouter = require('./Controllers/eventController');
const uri = 'mongodb://localhost:27017/Production';
mongoose.connect(uri);
app.use(cors()); 
app.use(express.json());
app.use('',producerRouter);
app.use('',eventRouter);

app.listen(3000,() =>{
    console.log("listen to port 3000");    
});
