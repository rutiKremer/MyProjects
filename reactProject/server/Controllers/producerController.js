const express = require('express');
const router = express.Router();
const ProducerSchema = require('../Schemas/producerSchema');
const { default: mongoose } = require('mongoose');

router.use(express.json());

router.get('/producer/:email', async (req, res) => {
    const email = req.params.email;
    try {
        const producer = await ProducerSchema.findOne({ email: email });
        if (producer) {
            res.status(200).send(producer);
        } else {
            res.status(404).json({ message: 'Producer not found' });
        }
    } catch (err) {
        res.status(500).json({ message: 'server error', err });
    }
});

router.post('/producer', async (req, res) => {
    try {
        const producerData = req.body;
        const newProducer = new ProducerSchema({
            name: producerData.name,
            email: producerData.email,
            phone: producerData.phone,
            description: producerData.description
        });
        await newProducer.save();
        res.status(200).send("the detail saved succesfuly")
    } catch (err) {
        res.status(500).json({ message: 'server error', err });
    }
});

router.put('/producer/:email', async (req, res) => {
    try {
        const { name, phone, description } = req.body;
        const updateProducer = await ProducerSchema.findOneAndUpdate({ email: req.params.email }, { name, phone, description }, );
        if (updateProducer)
            res.status(200).send("update succesfuly");
        else {
            res.status(404).json({ message: 'Producer not found' });
        }
    } catch (err) {
        res.status(500).json({ message: 'server error', err });
    }
});

module.exports = router;