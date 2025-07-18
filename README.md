# FileReader Library & CLI

A clean, extensible file reading library and command-line interface (CLI) in C#/.NET, supporting reading and security features for Text, XML, and JSON files.  
Implements encryption (using a strategy pattern) and role-based security (using a decorator pattern).  
Developed for a coding challenge/job assignment.

---

## Features

- **Read Text, XML, and JSON files** via CLI.
- **Encrypted file support:** Uses a pluggable encryption strategy (default: reverse text).
- **Role-based security:** Admin and user roles, easily extendable.
- **Extensible design:** Add new file types, encryption methods, or security strategies without modifying core logic.
- **Modern patterns:** Strategy, Decorator, and Factory.
- **Modular folder structure** and clean codebase.
- **Bonus:** Unified CLI for all features.

---

## Getting Started

### Prerequisites

- [.NET 8.0 SDK or later](https://dotnet.microsoft.com/en-us/download)
- Git

### Build and Run

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/FileReader.git
   cd FileReader

2. **Build the solution:**
   ```bash
    dotnet build

3. **Run the CLI app:**
   ```bash
   cd FileReader.CLI
   dotnet run

---

### Usage

1. Select file type: Choose Text, XML, or JSON.
2. Enter file path: Type or paste the full file path.
3. Encryption prompt: Choose if the file is encrypted (reverse encrypted).
4. Role-based security prompt: Choose if role-based access control should be applied.
5. Role selection: If role security is enabled, select your role (admin/user).

View content: File is read and output is displayed.

After each file, you can process another without restarting the program.

---

### File Examples
Text/XML/JSON files are all supported.

Encrypted files are simply reversed (character-wise).

For role security:
- admin can read any file.
- user can only read files whose name starts with public_.

---

###  Architecture Overview

- **Readers:** Implementations for each file type (TextFileReader, XmlFileReader, JsonFileReader).
- **Encryption:** Swappable encryption strategies (IEncryptionStrategy, ReverseEncryptionStrategy, etc).
- **Role-based Security:** Swappable security strategies and decorator (IRoleSecurityStrategy, SimpleRoleSecurityStrategy, RoleBasedFileReader).
- **Factory:** Central point to instantiate correct reader (FileReaderFactory).
- **Prompters:** CLI user input helpers.
- **Extensible:** Add new file types, strategies, or prompts with minimal changes.

---

### Git Versioning
Major features were implemented in steps and tagged as:

- **v1** — Basic text file reader
- **v2** — Add XML reader
- **v3** — Encrypted text file support
- **v4** — Role-based XML support
- **v5** — Encrypted XML support
- **v6** — Role-based Text support
- **v7** — Add JSON support
- **v8** — Encrypted JSON support
- **v9** — Role-based JSON support
- **v10** — Unified prompts & folder structure refactor

---

### Author
Denis Silva
