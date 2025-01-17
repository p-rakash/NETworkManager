---
layout: default
title: IP Geolocation
parent: Application
grand_parent: Documentation
nav_order: 20
description: "Documentation of IP Geolocation"
permalink: /Documentation/Application/IPGeolocation
---

# IP Geolocation

New Feature
{: .label .label-green }

2023.10.22.0
{: .label .label-purple }

With **IP Geolocation** you can retrieve geolocation information for a fully qualified domain name (FQDN) or a public IP address.

{: .note }
IP geolocation data is provided by [ip-api.com](https://ip-api.com/) and the API endpoint `http://ip-api.com/json/<host>` is queried when the information is requested. The free API endpoint is limited to 45 requests per minute, supports only the `http` protocol and is available for non-commercial use only.

Example inputs:

- `borntoberoot.net`
- `1.1.1.1`

![IPGeolocation](20_IPGeolocation.png)

{: .note}
Right-click on the result to copy the information.

<hr>

## Profile

### Inherit host from general

Inherit the host from the general settings.

**Type:** `Boolean`

**Default:** `Enabled`

{: .note }
If this option is enabled, the [host](#host) is overwritten by the host from the general settings and the [host](#host) is disabled.

### Host

Host (FQDN or public IP address) to query for IP geolocation information.

**Type:** `String`

**Default:** `Empty`

**Example:**

- `borntoberoot.net`
- `1.1.1.1`
