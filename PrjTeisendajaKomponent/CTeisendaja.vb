Public Class CTeisendaja
    Implements ITeisendaja

    Const KM2MI = 1.609344

    Public Function convertKilometersToMiles(ByRef kilometers As Double) As Double Implements ITeisendaja.convertKilometersToMiles
        Return kilometers / KM2MI
    End Function
End Class
