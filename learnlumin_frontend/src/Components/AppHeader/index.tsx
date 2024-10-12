import { AppBar, Button, Container, Toolbar, Typography } from "@mui/material";
import React from "react";
import { FC } from "react";
import "./AppHeader.css";
import {Link} from "react-router-dom"


export const AppHeader : FC = () =>
{
    return(

        <AppBar position="static">
            <Container maxWidth={false}>
                <Toolbar disableGutters className="menu-container">

                    <Button variant="contained" component={Link} to="/">
                        <Typography className="menu-button-text">Home</Typography>
                    </Button>

                    <Button variant="contained" component={Link} to="/profile">
                        <Typography className="menu-button-text">Profile</Typography>
                    </Button>

                    <Button variant="contained" component={Link} to="/courses">
                        <Typography className="menu-button-text">Courses</Typography>
                    </Button>

                    <Button variant="contained" component={Link} to="/quizzes">
                        <Typography className="menu-button-text">Quizzes</Typography>
                    </Button>

                    <Button variant="contained" component={Link} to="/community">
                        <Typography className="menu-button-text">Community</Typography>
                    </Button>

                    <Button variant="contained" component={Link} to="/liveclasses">
                        <Typography className="menu-button-text">Live Classes</Typography>
                    </Button>

                    <Button variant="contained" component={Link} to="/about">
                        <Typography className="menu-button-text">About</Typography>
                    </Button>

                </Toolbar>
            </Container>
        </AppBar>

    )
}