# Security Concepts

## Root of Trust (Rot)

A hardware root of trust (RoT) is the basis for ensuring security in an embedded system. It is based on the idea that an intelligent system has an immutable (non-interruptible) and repeatable sequence that must be executed during initialization.

## Identity

RoT is the basis of the security of a microcontroller system, a unique identity is the key to a valid PKI.
The private key must be protected by the hardware RoT and the public part is held in a certificate, both of which are provisioned during manufacturing. The certificate will be signed by a certificate authority thus providing a means of authentication for the identity. 

## Hardware Security Module

It performs varity of computer cyptogphraphic operations like 
  1. key management.
  2. key exchange.
  3. encryption/dycryption.
  
## public key encryption techniques.

  1. Rivest, Shamir, Adleman ( RSA).
  2. Elliptical Curve Cryptography (ECC).

## harware root of trust.

 It can includes
1.Trusted Execution Environment (TEE)
2.Cryptographics function ( AES, True Random Number Generator)
3.Secure service available to main application.
