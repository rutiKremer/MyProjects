const mongoose = require('mongoose');
const Schema = mongoose.Schema;
const uri = 'mongodb://localhost:27017/Production';
mongoose.connect(uri);

const eventSchema = new Schema({
    name: {
        type: String,
        required: true
    }, 
    description: {
        type: String,
        required: true
    },
    producerId: {
        type: String,
        required: true
    }
});

module.exports = mongoose.model('events',eventSchema);
