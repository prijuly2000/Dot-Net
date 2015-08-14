<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>
  
    <xsl:template match="Company">
      <xsl:for-each select="Emp">
        <h3>
        <xsl:value-of select="Eid"/>
          <xsl:text>   </xsl:text>
        <xsl:value-of select ="EName"/>
        <xsl:value-of select="Basic"/>
        </h3>
      </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
