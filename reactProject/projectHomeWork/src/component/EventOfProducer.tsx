import axios from 'axios';
import { useEffect, useState } from "react";
import { Event } from "../types/event";
import { AddEvent } from './AddEvent';

export const EventOfProducer = (props: any) => {
    const [eventDetails, setEventDetails] = useState<Event[] | null>(null);
    const [eventDetailsById, setEventDetailsById] = useState<Event[] | null>(null);
    const [clicked, setClicked] = useState(false);
    const getEvents = async () => {
        try {
            const producer = await axios.get<Event[]>(`http://localhost:3000/events`);
            setEventDetails(producer.data);
            if (eventDetails != null) {
                let finall = eventDetails.filter(e => e.producerId == props.email);
                setEventDetailsById(finall);
            }
        } catch (err) {
            console.log(err);
        }
    }

    useEffect(() => {
        getEvents();
    }, [props.email]);


    const deleteEvent = async (id: string) => {
        try {
            await axios.delete(`http://localhost:3000/events/${id}`);
            setEventDetailsById(eventDetailsById?.filter(event => event._id !== id) || null);
            getEvents();
        } catch (err) {
            console.log(err);
        }
    }

    const click = () => {
        setClicked(true);
    }

    return (
        <div>
            {eventDetailsById && eventDetailsById.length > 0 ? (
                eventDetailsById.map(event => (
                    <div key={event._id}>
                        <a href={`/event/${event._id}/${event.name}/${event.description}/${event.producerId}`}>
                            {event.name}
                        </a>
                        <button onClick={() => deleteEvent(event._id)}>delete</button>
                    </div>
                ))
            ) : (
                <p>No events found</p>
            )}
            <button onClick={click}>add event</button>
            {clicked && <AddEvent/>}
        </div>
    )
}