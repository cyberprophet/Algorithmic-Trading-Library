﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShareInvest.Models.OpenAPI;

public class KiwoomUser : User
{
    [Key]
    public override string? Key
    {
        get; set;
    }
    public string? Name
    {
        get; set;
    }
    [Required]
    public string? Id
    {
        get; set;
    }
    [NotMapped]
    public string[]? Accounts
    {
        get; set;
    }
    public int NumberOfAccounts
    {
        get; set;
    }
    public bool IsNotMock
    {
        get; set;
    }
}