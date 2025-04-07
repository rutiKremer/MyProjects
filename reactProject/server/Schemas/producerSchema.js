const mongoose = require('mongoose');
const Schema = mongoose.Schema;
const uri = 'mongodb://localhost:27017/Production';
mongoose.connect(uri);

const producerSchema = new Schema({
    name: {
        type: String,
        required: true
    },
    email: {
        type: String,
        required: true
    }, 
    phone: {
        type: String,
        required: true
    },
    description: {
        type: String,
        required: true
    }
});

module.exports = mongoose.model('eventproducers', producerSchema);
