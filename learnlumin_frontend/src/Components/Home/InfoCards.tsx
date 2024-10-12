import React, { useEffect, useRef } from 'react';
import './Home.css'; // Ensure your CSS file is correctly linked

const InfoCards: React.FC = () => {
    const cardsRef = useRef<HTMLDivElement>(null);

    useEffect(() => {
        const observer = new IntersectionObserver(
            entries => {
                entries.forEach(entry => {
                    if (entry.isIntersecting) {
                        entry.target.classList.add('in-view');
                    }
                });
            },
            { threshold: 0.1 } // Trigger when 10% of the element is visible
        );

        if (cardsRef.current) {
            observer.observe(cardsRef.current);
        }

        return () => {
            if (cardsRef.current) {
                observer.unobserve(cardsRef.current);
            }
        };
    }, []);

    // Cards data
    const features = [
        { title: "Comprehensive Lesson Library", description: "Explore a wide range of subjects and interactive lessons." },
        { title: "Adaptive Quizzes", description: "Challenge yourself with dynamic quizzes that adapt to your level." },
        { title: "Community-Driven Content", description: "Create and share your own lessons and quizzes with others." },
        { title: "Gamified Learning", description: "Earn badges, achievements, and compete on leaderboards." },
        { title: "Live Classes and Workshops", description: "Join live sessions with experts and interactive workshops." },
        { title: "Personalized Study Plans", description: "Get recommendations and track your progress over time." }
    ];

    return (
        <div ref={cardsRef} className="features">
            {features.map((feature, index) => (
                <div key={index} className="feature-card">
                    <div className="feature-card-content">
                        <div className="feature-card-title">{feature.title}</div>
                        <div className="feature-card-description">{feature.description}</div>
                    </div>
                </div>
            ))}
        </div>
    );
};

export default InfoCards;
