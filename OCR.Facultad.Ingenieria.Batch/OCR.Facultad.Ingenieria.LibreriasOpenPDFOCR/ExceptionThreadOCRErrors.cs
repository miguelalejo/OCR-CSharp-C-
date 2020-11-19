﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OCR.Facultad.Ingenieria.LibreriasOpenPDFOCR
{
    public class ExceptionThreadOCRErrors : DirectoryNotFoundException
    {
        /// <summary>
        /// Indica si existe una excepción
        /// </summary>
        bool isException;
        /// <summary>
        /// Mensaje descriptivo del tipo de excepción
        /// </summary>
        string mensaje;
        /// <summary>
        ///  Indica si existe una excepción
        /// </summary>
        public bool IsException
        {
            get
            {
                return this.isException;
            }
            set
            {
                this.isException = value;
            }
        }
        /// <summary>
        /// Mensaje descriptivo del tipo de excepción
        /// </summary>
        public override string Message
        {
            get
            {
                return this.mensaje;
            }
           
        }
        /// <summary>
        /// HResult del tipo de error producido por una excepción
        /// </summary>
        public int HResultado
        {
            get
            {
                return this.HResult;                
            }

        }
        /// <summary>
        /// Constructor para una excepcion  
        /// </summary>
        /// <param name="unisException">TRUE si existe una excepción</param>
        /// <param name="unmensaje">Mensaje descriptivo de la excepción</param>
        /// <example>Como disparar una Excepción de tipo ExceptionThreadOCR 
        /// <code>
        /// throw new ExceptionThreadOCR(true,"Memoria Insuficiente");
        /// </code>
        /// </example>
        /// <example>Como capturar una Excepción de tipo ExceptionThreadOCR 
        /// <code>
        /// try
        /// {
        ///     throw new ExceptionThreadOCR(true,"Memoria Insuficiente");
        /// }
        /// catch(ExceptionThreadOCR error)
        /// {
        ///     MessageBox.Show(error.Message);
        /// }    
        /// </code>
        /// </example>
        public ExceptionThreadOCRErrors(bool unisException, string unmensaje)          
        {
            this.isException = unisException;
            this.mensaje = unmensaje;
       
        }        
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ExceptionThreadOCRErrors()
        {
            this.isException = false;
            this.mensaje = "";
        }

    }
}
