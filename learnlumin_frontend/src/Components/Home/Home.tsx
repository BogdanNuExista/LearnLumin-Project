import React from 'react';
import { Box } from '@mui/material';
import './Home.css';
import Header from './Header';
import Buttons from './Buttons';
import InfoCards from './InfoCards'

const Home: React.FC = () => {
    return (
        <Box className="home-container">
            <Box className="background-image"></Box>
            <Header />
            <Buttons />
            <InfoCards />
        </Box>
    );
};

export default Home;
