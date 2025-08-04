const { spawn } = require('child_process');
const path = require('path');

module.exports = async (req, res) => {
  // Set CORS headers
  res.setHeader('Access-Control-Allow-Origin', '*');
  res.setHeader('Access-Control-Allow-Methods', 'GET, POST, PUT, DELETE, OPTIONS');
  res.setHeader('Access-Control-Allow-Headers', 'Content-Type');

  // Handle preflight requests
  if (req.method === 'OPTIONS') {
    res.status(200).end();
    return;
  }

  try {
    // Serve static files
    if (req.url.startsWith('/css/') || req.url.startsWith('/js/') || req.url.startsWith('/lib/')) {
      const filePath = path.join(process.cwd(), 'wwwroot', req.url);
      res.sendFile(filePath);
      return;
    }

    // Default response for now
    res.status(200).json({
      message: 'Sistema de Registro de Usuários',
      status: 'running',
      timestamp: new Date().toISOString()
    });
  } catch (error) {
    console.error('Error:', error);
    res.status(500).json({ error: 'Internal Server Error' });
  }
}; 