# Benchmarks
This repository is responsable to have benchmark of the C# and .Net.

- [Find vs FirstOrDefault](#find-vs-firstordefault)
- [Count vs Any](#count-vs-any)
- [Exists vs Any vs Contains](#exists-vs-any-vs-contains)
- [Lower vs Upper vs IgnoreCase](#lower-vs-upper-vs-ignorecase)


## Find vs FirstOrDefault

| Method             | numberItems | item | Mean      | Error     | StdDev    | Ratio | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|------------------- |------------ |----- |----------:|----------:|----------:|------:|--------:|-----:|-------:|----------:|------------:|
| FindItem           | 9           | a    | 11.305 ns | 0.2897 ns | 0.5074 ns |  1.00 |    0.00 |    1 | 0.0187 |      88 B |        1.00 |
| FirstOrDefaultItem | 9           | a    | 19.626 ns | 0.3340 ns | 0.3124 ns |  1.74 |    0.08 |    2 | 0.0187 |      88 B |        1.00 |
|                    |             |      |           |           |           |       |         |      |        |           |             |
| FindItem           | 99          | a    |  9.814 ns | 0.1622 ns | 0.1438 ns |  1.00 |    0.00 |    1 | 0.0187 |      88 B |        1.00 |
| FirstOrDefaultItem | 99          | a    | 19.697 ns | 0.4477 ns | 0.6277 ns |  1.97 |    0.07 |    2 | 0.0187 |      88 B |        1.00 |
|                    |             |      |           |           |           |       |         |      |        |           |             |
| FindItem           | 999         | a    |  9.891 ns | 0.1434 ns | 0.1271 ns |  1.00 |    0.00 |    1 | 0.0187 |      88 B |        1.00 |
| FirstOrDefaultItem | 999         | a    | 18.559 ns | 0.2335 ns | 0.2070 ns |  1.88 |    0.02 |    2 | 0.0187 |      88 B |        1.00 |
|                    |             |      |           |           |           |       |         |      |        |           |             |
| FindItem           | 9999        | a    |  9.844 ns | 0.1949 ns | 0.1727 ns |  1.00 |    0.00 |    1 | 0.0187 |      88 B |        1.00 |
| FirstOrDefaultItem | 9999        | a    | 18.813 ns | 0.1624 ns | 0.1440 ns |  1.91 |    0.04 |    2 | 0.0187 |      88 B |        1.00 |
|                    |             |      |           |           |           |       |         |      |        |           |             |
| FindItem           | 99999       | a    | 10.994 ns | 0.2861 ns | 0.6035 ns |  1.00 |    0.00 |    1 | 0.0187 |      88 B |        1.00 |
| FirstOrDefaultItem | 99999       | a    | 18.293 ns | 0.1365 ns | 0.1066 ns |  1.75 |    0.08 |    2 | 0.0187 |      88 B |        1.00 |

## Count vs Any

| Method         | numberItems | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|--------------- |------------ |----------:|----------:|----------:|----------:|------:|--------:|-----:|----------:|------------:|
| CountListItems | 9           | 0.0025 ns | 0.0047 ns | 0.0042 ns | 0.0000 ns |     ? |       ? |    1 |         - |           ? |
| AnyListItems   | 9           | 4.8718 ns | 0.0381 ns | 0.0357 ns | 4.8616 ns |     ? |       ? |    2 |         - |           ? |
|                |             |           |           |           |           |       |         |      |           |             |
| CountListItems | 99          | 0.0005 ns | 0.0013 ns | 0.0010 ns | 0.0000 ns |     ? |       ? |    1 |         - |           ? |
| AnyListItems   | 99          | 4.8434 ns | 0.0292 ns | 0.0259 ns | 4.8457 ns |     ? |       ? |    2 |         - |           ? |
|                |             |           |           |           |           |       |         |      |           |             |
| CountListItems | 999         | 0.0078 ns | 0.0081 ns | 0.0072 ns | 0.0065 ns |     ? |       ? |    1 |         - |           ? |
| AnyListItems   | 999         | 4.8698 ns | 0.0236 ns | 0.0221 ns | 4.8704 ns |     ? |       ? |    2 |         - |           ? |
|                |             |           |           |           |           |       |         |      |           |             |
| CountListItems | 9999        | 0.0044 ns | 0.0053 ns | 0.0047 ns | 0.0028 ns |     ? |       ? |    1 |         - |           ? |
| AnyListItems   | 9999        | 4.8535 ns | 0.0235 ns | 0.0219 ns | 4.8506 ns |     ? |       ? |    2 |         - |           ? |
|                |             |           |           |           |           |       |         |      |           |             |
| CountListItems | 99999       | 0.0030 ns | 0.0050 ns | 0.0045 ns | 0.0003 ns |     ? |       ? |    1 |         - |           ? |
| AnyListItems   | 99999       | 5.1983 ns | 0.1225 ns | 0.2611 ns | 5.0950 ns |     ? |       ? |    2 |         - |           ? |

## Exists vs Any vs Contains

| Method       | numberItems | item | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|------------- |------------ |----- |-----------:|----------:|----------:|-----------:|------:|--------:|-----:|-------:|----------:|------------:|
| ExistsItem   | 9           | a    | 12.4276 ns | 0.2808 ns | 0.4202 ns | 12.2242 ns | 1.000 |    0.00 |    2 | 0.0187 |      88 B |        1.00 |
| AnyItem      | 9           | a    | 19.1941 ns | 0.3971 ns | 0.3900 ns | 19.0771 ns | 1.541 |    0.07 |    3 | 0.0187 |      88 B |        1.00 |
| ContainsItem | 9           | a    |  0.0008 ns | 0.0033 ns | 0.0031 ns |  0.0000 ns | 0.000 |    0.00 |    1 |      - |         - |        0.00 |
|              |             |      |            |           |           |            |       |         |      |        |           |             |
| ExistsItem   | 99          | a    | 11.4712 ns | 0.1092 ns | 0.0968 ns | 11.4790 ns | 1.000 |    0.00 |    2 | 0.0187 |      88 B |        1.00 |
| AnyItem      | 99          | a    | 19.6302 ns | 0.3959 ns | 0.3306 ns | 19.5244 ns | 1.712 |    0.04 |    3 | 0.0187 |      88 B |        1.00 |
| ContainsItem | 99          | a    |  0.0039 ns | 0.0043 ns | 0.0036 ns |  0.0037 ns | 0.000 |    0.00 |    1 |      - |         - |        0.00 |
|              |             |      |            |           |           |            |       |         |      |        |           |             |
| ExistsItem   | 999         | a    | 11.5718 ns | 0.0959 ns | 0.0850 ns | 11.5914 ns | 1.000 |    0.00 |    2 | 0.0187 |      88 B |        1.00 |
| AnyItem      | 999         | a    | 19.2408 ns | 0.2826 ns | 0.2644 ns | 19.2131 ns | 1.664 |    0.02 |    3 | 0.0187 |      88 B |        1.00 |
| ContainsItem | 999         | a    |  0.0072 ns | 0.0106 ns | 0.0099 ns |  0.0000 ns | 0.000 |    0.00 |    1 |      - |         - |        0.00 |
|              |             |      |            |           |           |            |       |         |      |        |           |             |
| ExistsItem   | 9999        | a    | 11.3603 ns | 0.1166 ns | 0.0910 ns | 11.3847 ns | 1.000 |    0.00 |    2 | 0.0187 |      88 B |        1.00 |
| AnyItem      | 9999        | a    | 18.6992 ns | 0.0933 ns | 0.0779 ns | 18.6904 ns | 1.647 |    0.02 |    3 | 0.0187 |      88 B |        1.00 |
| ContainsItem | 9999        | a    |  0.0070 ns | 0.0085 ns | 0.0075 ns |  0.0056 ns | 0.001 |    0.00 |    1 |      - |         - |        0.00 |
|              |             |      |            |           |           |            |       |         |      |        |           |             |
| ExistsItem   | 99999       | a    | 11.4201 ns | 0.0692 ns | 0.0614 ns | 11.4231 ns | 1.000 |    0.00 |    2 | 0.0187 |      88 B |        1.00 |
| AnyItem      | 99999       | a    | 19.2813 ns | 0.1426 ns | 0.1190 ns | 19.2878 ns | 1.687 |    0.01 |    3 | 0.0187 |      88 B |        1.00 |
| ContainsItem | 99999       | a    |  0.0056 ns | 0.0066 ns | 0.0062 ns |  0.0029 ns | 0.000 |    0.00 |    1 |      - |         - |        0.00 |

## Lower vs Upper vs IgnoreCase

| Method     | numberItems | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|----------- |------------ |----------:|----------:|----------:|----------:|------:|--------:|-----:|----------:|------------:|
| Lower      | 9           | 1.1013 ns | 0.0363 ns | 0.0322 ns | 1.1031 ns |  1.00 |    0.00 |    2 |         - |          NA |
| Upper      | 9           | 1.0672 ns | 0.0492 ns | 0.0604 ns | 1.0455 ns |  0.98 |    0.07 |    1 |         - |          NA |
| IgnoreCase | 9           | 1.0988 ns | 0.0373 ns | 0.0349 ns | 1.0920 ns |  0.99 |    0.04 |    2 |         - |          NA |
|            |             |           |           |           |           |       |         |      |           |             |
| Lower      | 99          | 1.0617 ns | 0.0250 ns | 0.0222 ns | 1.0614 ns |  1.00 |    0.00 |    2 |         - |          NA |
| Upper      | 99          | 1.0815 ns | 0.0422 ns | 0.0395 ns | 1.0668 ns |  1.02 |    0.05 |    2 |         - |          NA |
| IgnoreCase | 99          | 0.8531 ns | 0.0280 ns | 0.0249 ns | 0.8565 ns |  0.80 |    0.03 |    1 |         - |          NA |
|            |             |           |           |           |           |       |         |      |           |             |
| Lower      | 999         | 1.0695 ns | 0.0218 ns | 0.0204 ns | 1.0709 ns |  1.00 |    0.00 |    2 |         - |          NA |
| Upper      | 999         | 1.0836 ns | 0.0114 ns | 0.0095 ns | 1.0813 ns |  1.01 |    0.02 |    2 |         - |          NA |
| IgnoreCase | 999         | 0.8120 ns | 0.0314 ns | 0.0294 ns | 0.8077 ns |  0.76 |    0.03 |    1 |         - |          NA |
|            |             |           |           |           |           |       |         |      |           |             |
| Lower      | 9999        | 1.0851 ns | 0.0253 ns | 0.0225 ns | 1.0860 ns |  1.00 |    0.00 |    3 |         - |          NA |
| Upper      | 9999        | 0.9890 ns | 0.0221 ns | 0.0543 ns | 0.9699 ns |  0.98 |    0.08 |    2 |         - |          NA |
| IgnoreCase | 9999        | 0.8230 ns | 0.0169 ns | 0.0158 ns | 0.8230 ns |  0.76 |    0.02 |    1 |         - |          NA |
|            |             |           |           |           |           |       |         |      |           |             |
| Lower      | 99999       | 1.0079 ns | 0.0123 ns | 0.0115 ns | 1.0100 ns |  1.00 |    0.00 |    2 |         - |          NA |
| Upper      | 99999       | 1.0151 ns | 0.0132 ns | 0.0117 ns | 1.0134 ns |  1.01 |    0.01 |    2 |         - |          NA |
| IgnoreCase | 99999       | 0.7704 ns | 0.0099 ns | 0.0092 ns | 0.7694 ns |  0.76 |    0.01 |    1 |         - |          NA |












