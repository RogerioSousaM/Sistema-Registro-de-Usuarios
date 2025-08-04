const crypto = require('crypto');

module.exports = async (req, res) => {
  // Set CORS headers
  res.setHeader('Access-Control-Allow-Origin', '*');
  res.setHeader('Access-Control-Allow-Methods', 'POST, OPTIONS');
  res.setHeader('Access-Control-Allow-Headers', 'Content-Type');

  // Handle preflight requests
  if (req.method === 'OPTIONS') {
    res.status(200).end();
    return;
  }

  if (req.method !== 'POST') {
    return res.status(405).json({ error: 'Method not allowed' });
  }

  try {
    const { usuario, senha } = req.body;

    if (!usuario || !senha) {
      return res.status(400).json({ error: 'Usuário e senha são obrigatórios' });
    }

    // Hash da senha usando SHA256
    const senhaHash = crypto.createHash('sha256').update(senha).digest('hex');

    // Simulação de autenticação (em produção, isso viria do banco de dados)
    // Para teste, vamos aceitar qualquer usuário com senha "123456"
    const senhaTeste = crypto.createHash('sha256').update('123456').digest('hex');
    
    if (senhaHash === senhaTeste) {
      res.status(200).json({
        success: true,
        message: 'Login realizado com sucesso!',
        usuario: usuario
      });
    } else {
      res.status(401).json({
        success: false,
        error: 'Usuário ou senha inválidos'
      });
    }
  } catch (error) {
    console.error('Login error:', error);
    res.status(500).json({ error: 'Erro interno do servidor' });
  }
}; 