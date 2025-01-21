/* General styles for the body */
body {
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    display: flex;
    justify-content: center;
    align-items: flex-start; /* Aligning at the top */
    min-height: 100vh;
    margin: 0;
    background-color: #f7f8fa; /* Light background for contrast */
    padding: 20px;
}

/* Chatbot container */
.chatbot-popup {
    width: 100%; /* Full width */
    max-width: 400px; /* Max width of the chatbot */
    background-color: #ffffff; /* White background for the chatbot */
    box-shadow: 0 4px 16px rgba(0, 0, 0, 0.2); /* Subtle shadow for depth */
    border-radius: 20px; /* Rounded corners */
    overflow: hidden; /* Hide overflow */
    display: flex;
    flex-direction: column; /* Stack children vertically */
}

/* Header styles */
.chat-header {
    background-color: #673ab7; /* Purple header background */
    padding: 15px;
    display: flex;
    justify-content: space-between; /* Space between elements */
    align-items: center; /* Center items vertically */
    color: #ffffff; /* White text for contrast */
    border-top-left-radius: 20px; /* Rounded top left corner */
    border-top-right-radius: 20px; /* Rounded top right corner */
}

/* Header info styles */
.header-info {
    display: flex;
    align-items: center; /* Align items vertically */
}

/* Chat body styles */
.chat-body {
    flex: 1; /* Take available space */
    padding: 20px; /* Inner padding */
    overflow-y: auto; /* Scroll if content exceeds */
    background-color: #f1f2f6; /* Light gray background */
}

/* Message styles */
.message {
    display: flex; /* Flexbox for layout */
    align-items: flex-start; /* Align items */
    margin-bottom: 20px; /* Space between messages */
}

/* User and bot message differentiation */
.message.bot-message {
    flex-direction: row; /* Default direction for bot messages */
}

.message.user-message {
    justify-content: flex-end; /* Align user messages to the right */
    flex-direction: row-reverse; /* Reverse order for user messages */
}

/* Message text styles */
.message-text {
    background-color: #e1f5fe; /* Light blue background for bot messages */
    padding: 15px; /* Inner padding */
    border-radius: 20px; /* Rounded corners */
    max-width: 75%; /* Maximum width */
    color: #333; /* Dark text color */
    font-size: 14px; /* Font size */
}

/* Different color for user messages */
.message.user-message .message-text {
    background-color: #c5e1a5; /* Light green for user messages */
}

/* Avatar styles */
.bot-avatar {
    margin-right: 15px; /* Space between avatar and text */
}

/* Footer styles */
.chat-footer {
    display: flex; /* Flexbox layout */
    background-color: #fafafa; /* Light footer background */
    padding: 15px; /* Inner padding */
    align-items: center; /* Center vertically */
    border-bottom-left-radius: 20px; /* Rounded bottom left corner */
    border-bottom-right-radius: 20px; /* Rounded bottom right corner */
}

/* Input styles */
.message-input {
    flex: 1; /* Take available space */
    border: none; /* No border */
    padding: 10px; /* Inner padding */
    border-radius: 10px; /* Rounded corners */
    resize: none; /* Prevent resizing */
    height: 40px; /* Fixed height */
    outline: none; /* No outline on focus */
    background-color: #e3f2fd; /* Light blue background for input */
    color: #333; /* Dark text color */
    font-size: 14px; /* Font size */
}

/* Button styles */
.chat-controls button {
    border: none; /* No border */
    background: none; /* No background */
    font-size: 24px; /* Button size */
    cursor: pointer; /* Pointer cursor on hover */
    margin-left: 10px; /* Space between buttons */
    color: #673ab7; /* Purple color for buttons */
}

/* Typing indicator styles */
.thinking-indicator {
    display: flex; /* Flexbox for dots */
    gap: 6px; /* Space between dots */
    margin-left: 60px; /* Align with user message */
}

/* Dot styles for typing indicator */
.thinking-indicator .dot {
    width: 8px; /* Dot width */
    height: 8px; /* Dot height */
    background-color: #673ab7; /* Purple color for dots */
    border-radius: 50%; /* Circular dots */
    animation: bounce 1s infinite; /* Bounce animation */
}

/* Bounce animation for typing indicator */
@keyframes bounce {
    0%, 100% {
        transform: translateY(0); /* Original position */
    }
    50% {
        transform: translateY(-10px); /* Move up */
    }
}
