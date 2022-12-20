![Logo]()

WebScraping.UserAgent DLL para capturar o User Agente do seu navegado, muito utilizado em aplicaçoes WebScraping com Html Agility Pack.

## Installation

Use the package manager [Package Manager](https://www.nuget.org/packages/WebScraping.UserAgent) to install WebScraping.UserAgent.

```bash
PM > Install-Package WebScraping.UserAgent -Version 1.0.1
```

## Usage

```csharp
using WebScraping.UserAgent;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new BrowserUserAgent().UserAgentBrowser);
        }
    }
}

```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.