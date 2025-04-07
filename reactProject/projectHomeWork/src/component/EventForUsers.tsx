import axios from 'axios';
import { useEffect, useState } from 'react';
import { Event } from "../types/event";
import { ProducerDetails } from './ProducerDetails';

export const EventForUsers = () => {

    const [events, setEvents] = useState<Event[] | null>(null);
    const [filterName, setFilterName] = useState<string>('');
    const [selectedProducerEmail, setSelectedProducerEmail] = useState<string | null>(null); // מצב לאחסון דוא"ל המפיק הנבחר

    const getAllEvents = async () => {
        try {
            let events = await axios.get('http://localhost:3000/events');
            setEvents(events.data);
        } catch (err) {
            console.error('Error fetching data:', err);
        }
    }

    useEffect(() => {
        getAllEvents();
    }, []);

    const filter = () => {
        if (!events) return [];
        return events.filter(event => event.name.toLowerCase().includes(filterName.toLowerCase()));
    };

    const filteredEvents = filter();

    return (
        <div>
            <input type="text" name="eventName" value={filterName} onChange={(e) => setFilterName(e.target.value)} />
            <button onClick={filter}>filter by name</button>
            {filteredEvents.length > 0 ? (
                filteredEvents.map(event => (
                    <div key={event._id}>
                        <a href={`/event/${event._id}/${event.name}/${event.description}/${event.producerId}`}>
                            {event.name}
                        </a>
                        <button onClick={() => setSelectedProducerEmail(event.producerId)}>producer details</button>
                    </div>
                ))
            ) : (
                <p>No events found</p>
            )}
            {selectedProducerEmail && <ProducerDetails email={selectedProducerEmail} />} {/* הצגת פרטי המפיק */}
        </div>
    )
}