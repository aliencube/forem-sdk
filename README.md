# Forem/Dev.To SDK #

This is an **UNOFFICIAL** wrapper package of the [Forem/DevTo](https://github.com/forem/forem) API used for [https://dev.to](https://dev.to/), using [AutoRest](https://aka.ms/autorest).


## Acknowledgement ##

* This is a wrapper package of the APIs offered by [Forem/DevTo](https://github.com/forem/forem), using [AutoRest](https://aka.ms/autorest).
* This is **NOT** affiliated with [Forem/DevTo](https://github.com/forem/forem) by any means.


## Official API Document ##

* Official API document: [https://docs.forem.com/api/](https://docs.forem.com/api/)
* The document page provides an Open API specification [complying to v3.0.3](http://spec.openapis.org/oas/v3.0.3).
* Current API version is `0.9.4`.


## Generating SDK ##

Make sure you have [AutoRest](https://aka.ms/autorest) installed on your machine.

```bash
npm install -g autorest
```

Run the following command to generate SDK.

```bash
autorest config-file.yaml --input-file=forem.swagger-<version>.json
```


## Getting Started ##

* ✅ [.NET SDK](./docs/csharp.md)
* 🔲 JavaScript SDK: TBD
* 🔲 Python SDK: TBD
* 🔲 Java SDK: TBD
* 🔲 Go SDK: TBD
* 🔲 PHP SDK: TBD


## TO-DO List ##

* ✅ .NET SDK on [NuGet](https://nuget.org/): [https://www.nuget.org/packages/Forem.DevTo/](https://www.nuget.org/packages/Forem.DevTo/)
* 🔲 JavaScript SDK on [npm](https://npmjs.com/)
* 🔲 Python SDK on [PyPI](https://pypi.org/)
* 🔲 Java SDK on [Maven](https://mvnrepository.com/)
* 🔲 Go SDK on ???
* 🔲 PHP SDK on [Composer](https://getcomposer.org/)


## Contribution ##

Your contributions are always welcome! All your work should be done in your forked repository. Once you finish your work with corresponding tests, please send us a pull request onto our `dev` branch for review.


## License ##

**Forem/DevTo SDK** is released under [MIT License](http://opensource.org/licenses/MIT)

> The MIT License (MIT)
>
> Copyright (c) 2021 [aliencube.org](http://aliencube.org)
> 
> Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
> 
> The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
> 
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
