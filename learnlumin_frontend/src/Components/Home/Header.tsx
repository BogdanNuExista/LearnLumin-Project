import React from 'react';
import { Typography } from '@mui/material';
import './Home.css';

const Header: React.FC = () => {
    return (
        <div className="header">
            <div className="header-box">
                <Typography className="main-header" variant="h1">
                    Ready to boost up your grades?
                </Typography>
                <Typography className="subtext" variant="h6">
                    LearnLumin provides interactive lessons, quizzes, and community-driven content to help you excel in any subject.
                </Typography>
            </div>
        </div>
    );
};


export default Header;
