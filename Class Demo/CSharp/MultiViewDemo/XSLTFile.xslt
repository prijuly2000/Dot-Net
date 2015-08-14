<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="mobile">
        <xsl:for-each select="company">
            <xsl:text>   </xsl:text>
            <xsl:text>   </xsl:text>
            <xsl:text>   </xsl:text>
            <xsl:text>   </xsl:text>
            <xsl:text></xsl:text>
            <xsl:value-of select="name"/>
            <xsl:text></xsl:text>
            <xsl:text>   </xsl:text>
            <xsl:text>   </xsl:text>
            <xsl:text>   </xsl:text>
            <xsl:value-of select="price"/>
            <xsl:text>   </xsl:text>
            <xsl:text>   </xsl:text>
            <xsl:text>   </xsl:text>
            <xsl:text>   </xsl:text>
            <xsl:text></xsl:text>
            <xsl:value-of select="model"/>
            <xsl:text>   </xsl:text>
            <xsl:text>   </xsl:text>
            <xsl:text>   </xsl:text>
            <xsl:text>   </xsl:text>
            <xsl:text></xsl:text>
           
         
        </xsl:for-each>
        
    </xsl:template>
</xsl:stylesheet>
