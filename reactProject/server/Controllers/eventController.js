const express = require('express');
const router = express.Router();
const eventsSchema = require('../Schemas/eventSchema');
const { default: mongoose } = require('mongoose');

router.use(express.json());

router.get('/events', async (req, res) => {
    try {
        const events = await eventsSchema.find();
        if (events) {
            res.status(200).send(events);
        } else {
            res.status(404).json({ message: 'Producer not found' });
        }
    } catch (err) {
        res.status(500).json({ message: 'server error', err });
    }
});

router.get('/events/:id', async (req, res) => {
    const id = req.params.id;
    try {
        const event = await eventsSchema.findOne({ _id: id });
        if (event) {
            res.status(200).send(event);
        } else {
            res.status(404).json({ message: 'Producer not found' });
        }
    } catch (err) {
        res.status(500).json({ message: 'server error', err });
    }
});

router.post('/events', async (req, res) => {
    try {
        const eventData = req.body;
        const newEvent = new eventsSchema({
            id: eventData.id,
            name: eventData.name,
            description: eventData.description,
            producerId: eventData.producerId
        });
        await newEvent.save();
        res.status(200).send("the detail saved succesfuly")
    } catch (err) {
        res.status(500).json({ message: 'server error', err });
    }
});

router.put('/events/:id', async (req, res) => {
    try {
        await eventsSchema.findByIdAndUpdate(req.params.id.trim(), req.body, { new: true });
        res.status(200).send("update succesfuly");
    } catch (err) {
        res.status(500).json({ message: 'server error', err });
    }
});

router.delete('/events/:id',async (req, res) => {
    try{
        const event =await eventsSchema.findById(req.params.id);
        if(event){
            await eventsSchema.deleteOne({ _id: req.params.id });
            res.send(200).json({ message: 'deleted succesfull'});
        }
    }catch(err){
        res.status(500).json({ message: 'server error', err });
    }
 });

module.exports = router;