/* Reset and Variables */
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

:root {
  --primary-color: #FF6565;
  --text-color: #fff;
  --bg-color: #000;
  --font-family: 'Arial', sans-serif;
}

/* Base */
body {
  font-family: var(--font-family);
  color: var(--text-color);
  background-color: var(--bg-color);
}

a {
  text-decoration: none;
  color: inherit;
}

ul {
  list-style: none;
}

/* Header / Hero Section */
.hero {
  background-image: url('images/headphones_hero_1.jpg');
  background-size: cover;
  background-position: center;
  padding: 60px 20px;
}

.container {
  max-width: 1200px;
  margin: 0 auto;
}

.navbar {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.logo {
  height: 40px;
}

.navbar nav ul {
  display: flex;
  gap: 20px;
}

.hero-content {
  margin-top: 100px;
  text-align: center;
}

.hero-content h1 {
  font-size: 48px;
  margin-bottom: 20px;
}

.hero-content p {
  font-size: 20px;
  margin-bottom: 30px;
}

.cta-btn {
  background-color: var(--primary-color);
  padding: 12px 24px;
  border-radius: 25px;
  color: white;
  font-weight: bold;
}

/* Results Section */
.results-section {
  background-color: #1a1a1a;
  padding: 80px 20px;
  text-align: center;
}

.results-section h2 {
  font-size: 36px;
  margin-bottom: 20px;
}

.results-description {
  font-size: 18px;
  max-width: 700px;
  margin: 0 auto 60px;
}

.results-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(220px, 1fr));
  gap: 40px;
}

.result-card {
  background-color: #292929;
  padding: 30px 20px;
  border-radius: 12px;
}

.result-card h3 {
  font-size: 32px;
  color: var(--primary-color);
  margin-bottom: 10px;
}

.result-card p {
  font-size: 16px;
  color: #ccc;
}
